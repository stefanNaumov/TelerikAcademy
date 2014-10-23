//
//  EventManager.h
//  EventManager
//
//  Created by admin on 10/23/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Event.h"

@interface EventManager : NSObject{
    NSMutableArray *_eventsList;
}

@property (nonatomic) NSString *title;

@property( nonatomic) NSDate *date;

@property (nonatomic) NSArray *eventsList;

-(void) createEvent: (Event *) event;

-(NSArray *) listEventsByCategory: (NSString *) category;

-(void) sortEventsByDate;

-(void) sortEventsByTitle;

@end
