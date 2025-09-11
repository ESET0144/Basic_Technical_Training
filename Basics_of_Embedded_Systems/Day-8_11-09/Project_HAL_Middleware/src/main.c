#include "hal/hal_gpio.h"
#include <util/delay.h>
#include "../config/pin_config.h"


int main(void) {
    HAL_GPIO_init(LED_PORT, LED_PIN, OUTPUT);
    HAL_GPIO_init(BUTTON_PORT, BUTTON_PIN, INPUT);

    *(BUTTON_PORT) |= (1 << BUTTON_PIN);

    uint8_t led_state = 0;
    uint8_t last_button_state = 1;  // pull-up means idle state is HIGH

    while (1) {
        uint8_t button_state = HAL_GPIO_read(BUTTON_PORT, BUTTON_PIN);

        // Simple debounce and edge detection
        if (button_state && !last_button_state) {
            led_state = !led_state;
            HAL_GPIO_write(LED_PORT, LED_PIN, led_state);
            _delay_ms(50);  // debounce delay
        }

        last_button_state = button_state;
        _delay_ms(10);  // polling delay
    }
}   