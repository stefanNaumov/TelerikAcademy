//
//  Todo.m
//  ToDoList
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "Todo.h"

@implementation Todo


-(id)initWithEndDate:(NSDate *)date{
    self = [super self];
    
    if (self) {
        todoEndDate = date;
    }
    
    return self;
}

@end
