//
//  Battery.m
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Battery.h"

@implementation Battery

-(id) initWithHoursTalk:(double)hoursTalk
              hoursIdle:(double)hoursIdle {
    if (self = [super init]) {
        self.hoursIdle = hoursIdle;
        self.hoursTalk = hoursTalk;
    }
    
    return self;
}

@end