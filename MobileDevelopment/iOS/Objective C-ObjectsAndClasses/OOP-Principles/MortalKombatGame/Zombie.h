//
//  Zombie.h
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "MortalKombatGame/Skill.h"
#import "MortalKombatGame/Character.h"

@interface Zombie : NSObject<CharacterProtocol>{
    NSArray *_skills;
}

@property (nonatomic) NSString *name;

@property int life;

@property int power;

@property (nonatomic) NSArray *skills;

@end
