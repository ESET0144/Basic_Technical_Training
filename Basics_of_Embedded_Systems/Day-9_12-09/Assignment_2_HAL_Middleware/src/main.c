#include "hal/hal_gpio.h"
#include <util/delay.h>
#include "../config/pin_config.h"


int main(void) {
    HAL_GPIO_init(LED_PORT, LED_PIN, OUTPUT);
    HAL_GPIO_init(BUTTON_PORT, BUTTON_PIN, INPUT);
    // Enable pull-up resistor for button
    *(BUTTON_PORT) |= (1 << BUTTON_PIN);

    uint8_t mode = 0; // 0: slow blink, 1: fast blink, 2: always ON, 3: off
    uint8_t last_button_state = 1;
    uint8_t led_state = 0;
    uint16_t counter = 0;

    // Ensure LED starts OFF
    HAL_GPIO_write(LED_PORT, LED_PIN, 0);
    led_state = 0;

    while (1) {
        // Check button state frequently
        uint8_t button_state = HAL_GPIO_read(BUTTON_PORT, BUTTON_PIN);
        if (button_state == 0 && last_button_state == 1) { // Button pressed (falling edge)
            mode = (mode + 1) % 4;
            // Reset blink state on mode change
            counter = 0;
            led_state = (mode == 2) ? 1 : 0;
            HAL_GPIO_write(LED_PORT, LED_PIN, led_state);
            // Debounce
            _delay_ms(200);
        }
        last_button_state = button_state;

     
        switch (mode) {
            case 0: // Off
                HAL_GPIO_write(LED_PORT, LED_PIN, 0);
                break;

            case 1: // Slow blink
                if (counter >= 50) { // ~500ms if loop runs every 10ms
                    led_state = !led_state;
                    HAL_GPIO_write(LED_PORT, LED_PIN, led_state);
                    counter = 0;
                }
                break;
            case 2: // Fast blink
                if (counter >= 10) { // ~100ms if loop runs every 10ms
                    led_state = !led_state;
                    HAL_GPIO_write(LED_PORT, LED_PIN, led_state);
                    counter = 0;
                }
                break;
            case 3: // Always ON
                HAL_GPIO_write(LED_PORT, LED_PIN, 1);
                break;

            
        }
        counter++;
        _delay_ms(10); // Short delay for responsiveness
    }
}