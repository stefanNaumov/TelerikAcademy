//
//  Character.h
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "CharacterProtocol.h"
#import "Skill.h"

//base class for all characters
@interface Character : NSObject <CharacterProtocol>{
    
    NSString *_name;
    NSMutableArray *_skills;
    int _life;
    int _power;
    
}

@property (nonatomic) NSString *name;

@property (nonatomic) NSMutableArray *skills;

@property int life;

@property (nonatomic) int power;

@property BOOL isAlive;

@end
