//
//  EventManager.h
//  EventManager
//
//  Created by admin on 10/23/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Event.h"

@interface EventManager : NSObject

-(id)initWithTitle:(NSString *)title;

@property (nonatomic) NSString *title;
@property( nonatomic) NSDate *date;

-(void) createEvent: (Event *) event;

-(NSMutableArray *) listEvents;

-(NSArray *) listEventsByCategory: (NSString *) category;

-(void) sortEventsByDate;

-(void) sortEventsByTitle;

@end
