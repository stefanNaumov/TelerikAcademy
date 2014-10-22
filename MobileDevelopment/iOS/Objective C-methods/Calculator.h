//
//  Calculator.h
//  ObjectiveC-methods
//
//  Created by admin on 10/22/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>



@interface Calculator : NSObject{
    
    int result;
};

-(void) saveResult;
    
-(void) addValueToResult: (int) value;
    
-(void) divideResultByValue: (int) value;
    
-(void) substractResultByValue: (int) value;
    
-(void) multiplyResultByValue: (int) value;
    
-(int) getResult;
    


@end

