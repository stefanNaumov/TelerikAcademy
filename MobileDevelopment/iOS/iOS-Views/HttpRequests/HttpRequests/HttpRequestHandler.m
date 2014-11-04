//
//  HttpRequestHandler.m
//  HttpRequests
//
//  Created by admin on 11/3/14.
//  Copyright (c) 2014 admin. All rights reserved.
//

#import "HttpRequestHandler.h"

<<<<<<< HEAD
@implementation HttpRequestHandler{
    NSMutableData *_data;
}

-(void) get:(NSString *)urlStr withHeaders:(NSDictionary *) headers{
    
    NSURL *url = [NSURL URLWithString:urlStr];
    
    NSMutableURLRequest *request = [NSMutableURLRequest requestWithURL:url];
    [request setAllHTTPHeaderFields:headers];
    
    NSURLConnection *connection = [[NSURLConnection alloc] initWithRequest:request delegate:self];
    
    if (connection) {
        _data = [[NSMutableData alloc] init];
    }
}

-(void)connection:(NSString *)connection didReceiveData:(NSData *)data{
    [_data appendData:data];
}

=======
@implementation HttpRequestHandler
>>>>>>> 4cdd5ef159b2ebb558c8cf47b81607ba4e4842b0

@end
