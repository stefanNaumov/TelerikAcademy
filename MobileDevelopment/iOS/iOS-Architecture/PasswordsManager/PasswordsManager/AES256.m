//
//  AES256.m
//  PasswordsManager
//
//  Created by admin on 10/30/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "AES256.h"
#import <CommonCrypto/CommonCryptor.h>

@implementation NSData(AES256)

-(NSData *)AES256encryptWithKey:(NSString *)key{
    char keyPtr[kCCKeySizeAES256 + 1];
    
    bzero(keyPtr, sizeof(keyPtr));
    
    [key getCString:keyPtr maxLength:sizeof(keyPtr) encoding:NSUTF8StringEncoding];
    NSUInteger dataLength = [self length];
    
    size_t bufferSize = dataLength + kCCBlockSizeAES128;
    
    void *buffer = malloc(bufferSize);
    
    size_t numberOfBytes = 0;
    
    CCCryptorStatus status = CCCrypt(kCCEncrypt, kCCAlgorithmAES128, kCCOptionPKCS7Padding,
                                     keyPtr, kCCKeySizeAES256, NULL, [self bytes], dataLength, buffer, bufferSize, &numberOfBytes);
    
    if (status == kCCSuccess) {
        return [NSData dataWithBytesNoCopy:buffer length:numberOfBytes ];
    }
    
    free(buffer);
    return nil;
  }

-(NSData *)AES256decryptWithKey:(NSString *)key{
    char keyPtr[kCCKeySizeAES256 + 1];
    
    bzero(keyPtr, sizeof(keyPtr));
    
    [key getCString:keyPtr maxLength:sizeof(keyPtr) encoding:NSUTF8StringEncoding];
    NSUInteger dataLength = [self length];
    
    size_t bufferSize = dataLength + kCCBlockSizeAES128;
    
    void *buffer = malloc(bufferSize);
    
    size_t numberOfBytesDecrypted = 0;
    
    CCCryptorStatus status = CCCrypt(kCCDecrypt, kCCAlgorithmAES128, kCCOptionPKCS7Padding,
                                     keyPtr, kCCKeySizeAES256, NULL, [self bytes], dataLength, buffer, bufferSize, &numberOfBytesDecrypted);
    
    if (status == kCCSuccess) {
        return [NSData dataWithBytesNoCopy:buffer length:numberOfBytesDecrypted ];
    }
    
    free(buffer);
    
    return nil;
}
@end
