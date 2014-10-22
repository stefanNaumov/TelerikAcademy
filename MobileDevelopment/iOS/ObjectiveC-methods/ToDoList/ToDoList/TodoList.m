//
//  TodoList.m
//  ToDoList
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//


#import "TodoList.h"


@implementation TodoList

NSMutableArray *todoList;

-(void)addTodo:(Todo *)todo{
    todoList = [[NSMutableArray alloc] init];
    [todoList addObject:todo];
}

-(NSArray*) getTodoList{
    return todoList;
}

@end
