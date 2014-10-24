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
        _skills = [[NSMutableArray alloc] init];
        
    }
    
    return self;
}

-(void) kick:(int) damage{
    
}

-(void) punch: (int) damage{
    
}

-(void) useSkill:(NSString *)skillName{
    
}
@end
