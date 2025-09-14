#include <avr/io.h>
#include <util/delay.h>

// set PD4 as output
#define LED_PIN PD4

int main(void) {
    DDRD = (1 << LED_PIN);

    while (1) {
        // Turn LED on
        PD4 = 1;
        _delay_ms(5000);

        // Turn LED off
        PD4 = 0;
        _delay_ms(5000);

    }
}