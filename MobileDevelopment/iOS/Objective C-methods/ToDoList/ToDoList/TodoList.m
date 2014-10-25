//
//  TodoList.m
//  ToDoList
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//


#import "TodoList.h"


@implementation TodoList
-(id)init{
    self = [super self];
    if (self) {
        _todoList = [[NSMutableArray alloc] init];
    }
    
    return self;
}

-(void)addTodo:(Todo *)todo{
    
    [_todoList addObject:todo];
}

-(NSArray*) getTodoList{
    return _todoList;
}

@end
