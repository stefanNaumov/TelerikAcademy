//
//  EventManager.m
//  EventManager
//
//  Created by admin on 10/23/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "EventManager.h"

@implementation EventManager

-(id)init{
    self = [super self];
    if (self) {
        
        _eventsList = [[NSMutableArray alloc] init];
    }
    
    return self;
}

-(void) setDate:(NSDate *)date{
    self.date = [[NSDate alloc] init];
}

-(void) createEvent: (Event *) event{
    [_eventsList addObject:event];
    
}

-(NSArray *) eventsList{
    return _eventsList;
}


-(NSArray *) listEventsByCategory: (NSString *) category{
    NSPredicate *predicate = [NSPredicate predicateWithFormat:@"SELF.category LIKE [c] %@",category];
    NSArray *filtered = [_eventsList filteredArrayUsingPredicate:predicate];
    
    return filtered;
}

-(void) sortEventsByDate{
    
}

-(void) sortEventsByTitle{
    
}

@end
