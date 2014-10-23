//
//  EventManager.m
//  EventManager
//
//  Created by admin on 10/23/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "EventManager.h"

@implementation EventManager

NSMutableArray *eventsList;


-(id)initWithTitle:(NSString *)title{
    self = [super self];
    if (self) {
        self.title = title;
        eventsList = [[NSMutableArray alloc] init];
    }
    
    return self;
}

-(void) setDate:(NSDate *)date{
    self.date = [[NSDate alloc] init];
}

-(void) createEvent: (Event *) event{
    [eventsList addObject:event];
}

-(NSMutableArray *) listEvents{
    return eventsList;
}

-(NSArray *) listEventsByCategory: (NSString *) category{
    NSPredicate *predicate = [NSPredicate predicateWithFormat:@"SELF.category LIKE [c] %@",category];
    NSArray *filtered = [eventsList filteredArrayUsingPredicate:predicate];
    
    return filtered;
}

-(void) sortEventsByDate{
    
}

-(void) sortEventsByTitle{
    
}

@end
