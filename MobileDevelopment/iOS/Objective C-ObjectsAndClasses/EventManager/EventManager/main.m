//
//  main.m
//  EventManager
//
//  Created by admin on 10/23/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Event.h"
#import "EventManager.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
       
        Event *myEvent = [[Event alloc] init];
        [myEvent setCategory:@"Fun"];
        
        Event *mySecondEvent = [[Event alloc] init];
        [mySecondEvent setCategory:@"Thriller"];
        
        NSLog(@"%@",[myEvent category]);
        
        EventManager *eventManager = [[EventManager alloc] initWithTitle:@"Pool party"];
        
        [eventManager createEvent:myEvent];
        [eventManager createEvent:mySecondEvent];
        
        //string comparing is case insensitive
        NSArray *filtered = [eventManager listEventsByCategory:@"fun"];
        
        //should return 1. Only one event has category with name "fun"
        NSLog(@"%lul",(unsigned long)[filtered count]);
        
    }
    return 0;
}
