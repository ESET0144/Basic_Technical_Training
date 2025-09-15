#include <stdio.h>

#define LED_PIN 5

void delay_ms(int ms){
int i,j;
    for (i = 0; i<= ms; i++)
    {
        for (j = 0; j<=100000; j++)
        {
            //Time pass
        }
    }
}

void main(){

    int counter = 0;
    int threshold = 3;
    int max_blink = 5;
    int j;

    for (counter = 0; counter<=threshold; counter++)
    {
        for (j=0; j<=max_blink; j++)
        {
            printf("LED ON: counter %d blink_no : %d\n", counter, j);
            delay_ms(2000);

            printf("LED OFF: counter %d blink no.: %d \n", counter, j);
            delay_ms(2000);

        }

    }
}

