//
//  KinGeriKick.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "KinGeriKick.h"

@implementation KinGeriKick

static int const kingeriPowerConsumptionValue = 40;
static int const kingeriDamageValue = 60;

-(id)init{
    self = [super self];
    if (self) {
        
        [self setName:@"kingerikick"];
        
        [self setPowerConsumption:kingeriPowerConsumptionValue];
        
        [self setDamage:kingeriDamageValue];
    }
    
    return self;
}
@end
