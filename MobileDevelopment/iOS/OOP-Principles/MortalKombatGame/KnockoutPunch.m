//
//  KnockoutPunch.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "KnockoutPunch.h"

@implementation KnockoutPunch

static int const knockoutPunchPowerConsumption = 70;
static int const knockoutDamageValue = 45;
-(id)init{
    self = [super self];
    if (self) {
        [self setName:@"knockoutpunch"];
        [self setPowerConsumption:knockoutPunchPowerConsumption];
        [self setDamage:knockoutDamageValue];
        
    }
    
    return self;
}

@end
