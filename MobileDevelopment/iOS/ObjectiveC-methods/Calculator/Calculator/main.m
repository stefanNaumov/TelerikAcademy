//
//  main.m
//  Calculator
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Calculator.h"

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        Calculator *calc = [[Calculator alloc] init];
        
        [calc addValueToResult:5];
        NSLog(@"Result before save: %d",[calc getResult]);
        
        [calc saveResult];
        NSLog(@"Result after save: %d",[calc getResult]);
        
    }
    return 0;
}
