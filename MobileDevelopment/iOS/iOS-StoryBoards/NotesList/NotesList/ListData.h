//
//  ListData.h
//  NotesList
//
//  Created by admin on 10/30/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "NotesList.h"


@interface ListData : NSObject

-(void) addList:(NotesList *) list;

-(NSMutableArray *) getAll;

-(NotesList *) getByTitle: (NSString *) title;

-(NotesList *) getByIndex:(int) index;

-(void) removeList: (NotesList *) list;

-(void) removeListByTitle: (NSString *) title;

@end
