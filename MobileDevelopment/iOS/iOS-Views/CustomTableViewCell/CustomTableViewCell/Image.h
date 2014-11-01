//
//  Image.h
//  CustomTableViewCell
//
//  Created by admin on 11/1/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Image : NSObject

-(id) initWithTitle:(NSString *) title andFileName:(NSString *) fileName;

@property (nonatomic) NSString *title;

@property (nonatomic) NSString *fileName;

@end
