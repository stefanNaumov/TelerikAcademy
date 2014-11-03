//
//  AES256.h
//  PasswordsManager
//
//  Created by admin on 10/30/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <UIKit/UIKit.h>

@interface NSData (AES256)

-(NSData *) AES256encryptWithKey:(NSString *) key;

-(NSData *) AES256decryptWithKey:(NSString *) key;
@end
