//
//  Event.h
//  EventManager
//
//  Created by admin on 10/23/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Event : NSObject

@property (nonatomic) NSString *title;

@property (nonatomic) NSString *category;

@property (nonatomic) NSString *description;

@property (nonatomic) NSDate *date;

@property (nonatomic) NSMutableArray *guestList;

-(id) init;

-(void) addGuest: (NSString *) guest;

@end
