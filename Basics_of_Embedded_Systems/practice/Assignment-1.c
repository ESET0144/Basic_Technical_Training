#include <stdio.h> // Standard input/output library (for printf)
#include <time.h>
// Assuming a microcontroller environment where GPIO is configured for LED
// For a real embedded system, these would be register accesses
#define LED_PIN 5 	// Example LED pin number

// Function to simulate a delay (blocking delay)
void delay_ms(int ms) {
    volatile long i, j; 	// Use volatile to prevent optimization
    for (i=0;i<=ms;i++)
    {
        for (j=0;j<=10000;j++)
        {

        }
    }
   

   
   
}

void main() {
    int counter = 0; 	// Initialize counter variable
    int max_blinks = 5; 	// Maximum number of blinks
    int threshold = 4; 	// Threshold for conditional check

    int i,j;
    
    // The for loop iterates a known number of times (max_blinks)
    for (counter = 0; counter <= threshold;counter ++)
    {
        for (j=0;j<=max_blinks;j++)
        { 
             // Conditional statement (if-else)
        // Checks if the current counter value is less than the threshold
        
            // Simulate turning LED ON (e.g., set pin high)
            printf("LED ON (Counter: %d)\n", counter); 	// For simulation
             			// Delay for 200 milliseconds
                    delay_ms(2000);
            // Simulate turning LED OFF (e.g., set pin low)
            printf("LED OFF (Counter: %d)\n", counter); 	// For simulation
             		// Delay for 200 milliseconds
                    delay_ms(2000);
        
       
                    
        
        // Increment operator (++) used in the for loop condition
        // counter++ is equivalent to counter = counter + 1;
    
        }
    } 
    
        
    

    // Another conditional statement demonstrating logical operator
    
       // Logical AND operator (&&)
        printf("Blinking sequence completed.\n");
    

    // Example of a while loop
    int countdown = 3;
    //while loop for countdown
    while(countdown > 0) {
        printf("Countdown: %d\n", countdown);
         		// Decrement operator (--)
         //delay timer
         delay_ms(20000);
         countdown--;
    }
    printf("Liftoff!\n");

    // Indicate successful execution
} 