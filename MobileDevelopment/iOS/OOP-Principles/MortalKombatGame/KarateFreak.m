//
//  KarateFreak.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "KarateFreak.h"


@implementation KarateFreak

-(id)init{
    self = [super self];
    
    if (self) {
        
        [self setName:@"KarateFreak"];
        MegaPunch *megaPunch = [[MegaPunch alloc] init];
        
        NSMutableArray *skills = [[NSMutableArray alloc] init];
        [self setSkills:skills];
        
        //setting skills for particular character
        [_skills addObject:megaPunch];
    }
    
    return self;
}
@end
