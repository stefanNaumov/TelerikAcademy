//
//  Calculator.m
//  ObjectiveC-methods
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "Calculator.h"

@implementation Calculator

int tempResult = 0;

-(void) saveResult{
    result = tempResult;
}

-(void) addValueToResult:(int)value{
    tempResult += value;
}

-(void) substractResultByValue:(int)value{
    tempResult -= value;
}

-(void)multiplyResultByValue:(int)value{
    tempResult *= value;
}

-(void) divideResultByValue:(int)value{
    tempResult /= value;
}

-(int) getResult{
    return result;
}
@end
