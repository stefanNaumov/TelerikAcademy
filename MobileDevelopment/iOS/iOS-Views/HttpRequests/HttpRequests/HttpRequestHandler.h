//
//  HttpRequestHandler.h
//  HttpRequests
//
//  Created by admin on 11/3/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface HttpRequestHandler : NSObject<NSURLConnectionDelegate>

-(void) get:(NSString *) url
    withHeaders:(NSDictionary *) headers;

@end
