//
//  Character.h
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Skill.h"

@protocol CharacterProtocol <NSObject>

@required
@property (nonatomic) NSString *name;

@required
@property (nonatomic) NSArray *skills;

@required
@property int life;

@required
@property int power;

@required
@property BOOL isAlive;

-(void) kick;

-(void) punch;

-(void) useSkill: (NSString *) skillName;

-(void) takeHit: (int ) hitDamage;

@end
