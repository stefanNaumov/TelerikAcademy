//
//  Skill.h
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>

@protocol SkillProtocol <NSObject>

@required
@property (nonatomic) NSString *name;

@required
@property int powerConsumption;

@required
@property int damage;

@end
