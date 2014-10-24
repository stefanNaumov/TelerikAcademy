//
//  Zombie.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "Zombie.h"


@implementation Zombie

-(id)init{
    self = [super self];
    
    if (self) {
        
        [self setName:@"Zombie"];
        KinGeriKick *kick = [[KinGeriKick alloc] init];
        
        NSMutableArray *skills = [[NSMutableArray alloc] init];
        [self setSkills:skills];
        
        //setting skills for particular character
        [_skills addObject:kick];
    }
    
    return self;
}

@end
