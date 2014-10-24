//
//  Character.h
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "CharacterProtocol.h"

//base class for all characters
@interface Character : NSObject <CharacterProtocol>{
    
    NSString *_name;
    NSArray *_skills;
    int _life;
    int _power;
    
}

@property (nonatomic) NSString *name;

@property (nonatomic) NSArray *skills;

@property int life;

@property int power;

@property BOOL isAlive;

@end
