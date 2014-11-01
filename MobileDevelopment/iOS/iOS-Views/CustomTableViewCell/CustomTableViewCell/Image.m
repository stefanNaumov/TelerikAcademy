//
//  Image.m
//  CustomTableViewCell
//
//  Created by admin on 11/1/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "Image.h"

@implementation Image

-(id) initWithTitle:(NSString *)title andFileName:(NSString *)fileName{
    self = [super self];
    if (self) {
        [self setTitle:title];
        [self setFileName:fileName];
    }
    
    return self;
}

@end
