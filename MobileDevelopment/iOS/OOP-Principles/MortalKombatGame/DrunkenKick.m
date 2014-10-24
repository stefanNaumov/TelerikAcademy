//
//  DrunkenKick.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "DrunkenKick.h"

@implementation DrunkenKick

int const drunkenkickPowerConsumption = 80;
int const drunkenkickDamageValue = 15;

-(id)init{
    self = [super self];
    if (self) {
        [self setName:@"drunkenkick"];
        [self setPowerConsumption:drunkenkickPowerConsumption];
        [self setDamage:drunkenkickDamageValue];
    }
    
    return self;
}

@end
