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
        for (j=0;j<=1000;j++)
        {

        }
    }
   
	
// Adjust this value for desired delay
               // Do nothing, just waste time
   
   
}

int main() {
    int counter = 0; 	// Initialize counter variable
    int max_blinks = 5; 	// Maximum number of blinks
    int threshold = 3; 	// Threshold for conditional check

    int i,j;
    
    // The for loop iterates a known number of times (max_blinks)
    for (i=0;i<=counter;i++)
    {
        for (j=0;j<=max_blinks;j++)
        {
            
             // Conditional statement (if-else)
        // Checks if the current counter value is less than the threshold
        if (counter<=threshold)
        {
            // Simulate turning LED ON (e.g., set pin high)
            printf("LED ON (Counter: %d)\n", counter); 	// For simulation
             			// Delay for 200 milliseconds
                    delay_ms(200);
            // Simulate turning LED OFF (e.g., set pin low)
            printf("LED OFF (Counter: %d)\n", counter); 	// For simulation
             		// Delay for 200 milliseconds
                    delay_ms(200);
        }
        //else 
        else 
        {
            // If the counter is at or above the threshold
            printf("Counter reached threshold or above: %d\n", counter);
            		 // Longer delay
                     delay_ms(1000);
                    
        
        // Increment operator (++) used in the for loop condition
        // counter++ is equivalent to counter = counter + 1;
    
        }
        } 
    }
        
    

    // Another conditional statement demonstrating logical operator
    
       // Logical AND operator (&&)
        printf("Blinking sequence completed.\n");
    

    // Example of a while loop
    int countdown = 3;
    //while loop for countdown
        printf("Countdown: %d\n", countdown);
         		// Decrement operator (--)
         //delay timer
    
    printf("Liftoff!\n");

    return 0; 	// Indicate successful execution
} 