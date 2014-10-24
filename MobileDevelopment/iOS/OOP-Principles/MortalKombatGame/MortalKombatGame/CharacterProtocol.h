//
//  Character.h
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>

@protocol CharacterProtocol <NSObject>

@required
@property (nonatomic) NSString *name;

@required
@property (nonatomic) NSMutableArray *skills;

@required
@property int life;

@required
@property (nonatomic) int power;

@required
@property BOOL isAlive;

-(void) kick;

-(void) punch;

//returns integer - the damage causing to opponent
-(int) useSkill: (NSString *) skillName;

-(void) takeHit: (int ) hitDamage;

@end
