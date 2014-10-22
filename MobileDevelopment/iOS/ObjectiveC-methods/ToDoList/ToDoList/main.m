//
//  main.m
//  ToDoList
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Todo.h"
#import "TodoList.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        Todo *myTodo = [[Todo alloc] initWithEndDate:[[NSDate alloc] init]];
        
        TodoList *todoList = [[TodoList alloc] init];
        
        [todoList addTodo:myTodo];
        
        NSLog(@"%@",[todoList getTodoList]);
    }
    return 0;
}
