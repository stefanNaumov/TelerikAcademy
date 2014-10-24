//
//  main.m
//  MortalKombatGame
//
//  Created by admin on 10/24/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Zombie.h"
#import "KarateFreak.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        
        Zombie *z = [[Zombie alloc] init];
        
        NSLog(@"%d",[z power]);
        
        [z kick];
        [z kick];
        [z kick];
        [z kick];
        [z kick];
        [z kick];
        
        NSLog(@"Power: %d",[z power]);
        
        [z useSkill:@"Kingerikick"];
        
        
        NSLog(@"Power after kingeri: %d",[z power]);
        
        
    }
    return 0;
}
