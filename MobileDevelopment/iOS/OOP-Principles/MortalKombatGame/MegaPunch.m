//
//  MegaPunch.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "MegaPunch.h"

@implementation MegaPunch

static int const megapunchPowerConsumptionValue = 20;
static int const megapunchDamageValue = 20;

-(id)init{
    self = [super self];
    
    if (self) {
        
        [self setName: @"megapunch"];
        
        [self setPowerConsumption:megapunchPowerConsumptionValue];
        
        [self setDamage:megapunchDamageValue];
    }
    
    return self;
}
@end
