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
int const punchDamage = 5;

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

-(void) setPower:(int)power{
    
    _power += power;
}

-(NSMutableArray *) skills{
    return _skills;
}

-(int) power{
    return _power;
}

-(void) kick{
    _power += kickDamage;
}

-(void) punch{
    _power += punchDamage;
}

-(int) useSkill:(NSString *)skillName{
    Skill *currSkill;
    
    for (Skill *skill in [self skills]) {
        
        if ([[skill name] isEqualToString:[skillName lowercaseString]]) {
            currSkill = skill;
            break;
        }
    }
    
    if (currSkill) {
        if([self power] >= [currSkill powerConsumption]){
            
            [self setPower:-[currSkill powerConsumption]];
            
            return [currSkill damage];
        }
        else{
            return 0;
        }
        
    }
    else{
        return 0;
    }
}

-(void) takeHit:(int)hitDamage{
    _life -= hitDamage;
    
    if (_life <= 0) {
        _isAlive = FALSE;
    }
}
@end
