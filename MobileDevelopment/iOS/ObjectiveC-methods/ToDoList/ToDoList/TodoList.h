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
<<<<<<< HEAD

    NSMutableArray *todoList;

=======
    //NSMutableArray
>>>>>>> 6b361d6125acc00eb340ba9b9cea02bb1ece3bd8
}

-(void) addTodo:(Todo*) todo;

-(NSArray*) getTodoList;
<<<<<<< HEAD

=======
>>>>>>> 6b361d6125acc00eb340ba9b9cea02bb1ece3bd8
@end
