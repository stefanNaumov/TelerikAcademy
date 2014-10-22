//
//  TodoList.h
//  ToDoList
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Todo.h"

@interface TodoList : NSObject{

    NSMutableArray *todoList;

}

-(void) addTodo:(Todo*) todo;

-(NSArray*) getTodoList;

@end
