//
//  Character.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "Character.h"

@implementation Character

int const kickDamage = 10;
int const punchDamge = 5;

-(id)init{
    self = [super self];
    
    if (self) {
        _skills = [[NSMutableArray alloc] init];
        _isAlive = TRUE;
        _life = 100;
        _power = 10;
    }
    
    return self;
}

-(void) kick{
    _power += kickDamage;
}

-(void) punch{
    _power += punchDamge;
}

-(void) useSkill:(NSString *)skillName{
    //no implementation logic in base class
}

-(void) takeHit:(int)hitDamage{
    _life -= hitDamage;
    
    if (_life <= 0) {
        _isAlive = FALSE;
    }
}
@end
