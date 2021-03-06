//
//  Skill.h
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "SkillProtocol.h"

//base class for all Skills
@interface Skill : NSObject<SkillProtocol>{
    NSString *_name;
    int _powerConsumption;
    int _damage;
}

@property (nonatomic) NSString *name;

@property int powerConsumption;

@property int damage;

@end
