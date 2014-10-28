//
//  Password.m
//  PasswordsManager
//
//  Created by admin on 10/28/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "Password.h"

@implementation Password

-(id) init{
    return [self initWithAccountName:@"" andEncryptionCode:@"" andPassword:@""];
}

-(id) initWithAccountName: (NSString *) accountName
        andEncryptionCode: (NSString *) encryptionCode
              andPassword: (NSString *) password{
    self = [super self];
    if (self) {
        self.accountName = accountName;
        self.encryptionCode = encryptionCode;
        self.password = password;
    }
    
    return self;
}

@end
