#include <Arduino.h>
#include <avr/io.h>
#include <util/delay.h>


// set PD4 as output
#define DATA_PIND7 PD7
#define DATA_PIND6 PB0
#define DATA_PIND5 PB1
#define DATA_PIND4 PB2
#define ENABLE PB3
#define DATA_RS PB4


int main(void)
{
    DDRB =0XFF;
    DDRD |= (1<< DATA_PIND7);
    lcd_init();

    lcd_command(0x80);
    lcd_print("Hello World !");

    lcd_command(0xC0);
    lcd_print("LCD Working");

    while (1){

    }

    
}

void lcd_pulse()
{
    PORTB |= (1<<ENABLE);
    _delay_ms(10);
    PORTB &= ~(1<<ENABLE);
    _delay_ms(20);

}

void lcd_data(unsigned char cmd){

    PORTB |= (1<<DATA_RS);

    if (cmd & 0x80){
        PORTB |= (1<<DATA_PIND4);
    }
    else{
        PORTB &= ~(1<<DATA_PIND4);


    }

     if (cmd & 0x40) PORTB |= (1<<DATA_PIND5); else PORTB &= ~(1<<DATA_PIND5);
    
    if (cmd & 0x20) PORTB |= (1<<DATA_PIND6); else PORTB &= ~(1<<DATA_PIND6);
    
    if (cmd & 0x10) PORTD |= (1<<DATA_PIND7); else PORTD &= ~(1<<DATA_PIND7);

lcd_pulse();

    if (cmd & 0x08) PORTB |= (1<<DATA_PIND4); else PORTB &= ~(1<<DATA_PIND4);
    if (cmd & 0x04) PORTB |= (1<<DATA_PIND5); else PORTB &= ~(1<<DATA_PIND5);
    if (cmd & 0x02) PORTB |= (1<<DATA_PIND6); else PORTB &= ~(1<<DATA_PIND6);
    if (cmd & 0x01) PORTD |= (1<<DATA_PIND7); else PORTD &= ~(1<<DATA_PIND7);
lcd_pulse();
}


int lcd_command(unsigned int cmd) {
    PORTB &= ~(1<< DATA_RS); //RS = 0 command

    // Send High nibble
    if (cmd & 0x10) {
        PORTB |= (1<<DATA_PIND4);
    }
    else{
        PORTB &= ~(1<<DATA_PIND4);
    }
    if (cmd & 0x20) PORTB |= (1<<DATA_PIND5); else PORTB &= ~(1<<DATA_PIND5);
    
    if (cmd & 0x40) PORTB |= (1<<DATA_PIND6); else PORTB &= ~(1<<DATA_PIND6);
    
    if (cmd & 0x80) PORTD |= (1<<DATA_PIND7); else PORTD &= ~(1<<DATA_PIND7);

lcd_pulse();

    if (cmd & 0x01) PORTB |= (1<<DATA_PIND4); else PORTB &= ~(1<<DATA_PIND4);
    if (cmd & 0x02) PORTB |= (1<<DATA_PIND5); else PORTB &= ~(1<<DATA_PIND5);
    if (cmd & 0x04) PORTB |= (1<<DATA_PIND6); else PORTB &= ~(1<<DATA_PIND6);
    if (cmd & 0x08) PORTD |= (1<<DATA_PIND7); else PORTD &= ~(1<<DATA_PIND7);
lcd_pulse();
    
}

void lcd_init() {
    _delay_ms(20);
        lcd_command(0x02);
        lcd_command(0x28);
        lcd_command(0x0C);
        lcd_command(0x06);
        lcd_command(0x01);
        _delay_ms(20);
}

void lcd_print(char *str) {
while (*str)
{
    lcd_data(*str++);
}

}
