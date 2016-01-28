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

-(NSString *)description {
    
    return [
            NSString stringWithFormat:@"%d %f %f",
            self.type,
            self.hoursTalk,
            self.hoursIdle];
}

- (id) init {
    return [super init];
}

- (id) initWithHoursTalk: (double) hoursTalk
               hoursIdle: (double) hoursIdle {
    if (self = [super init]) {
        self.hoursTalk = hoursTalk;
        self.hoursIdle = hoursIdle;
    }
    
    return self;
}


- (id) initWithType: (Battery_Types) type
          hoursTalk: (double) hoursTalk
          hoursIdle: (double) hoursIdle {
    if ((self = [super init])) {
        self.type = type;
        self.hoursTalk = hoursTalk;
        self.hoursIdle = hoursIdle;
    }
    
    return self;
}

-(NSString*) model {
    if (!self.model) {
        self.model = @"";
    }
    
    return self.model;
}

-(double) hoursTalk {
    if (!self.hoursTalk) {
        self.hoursTalk = 0;
    }
    
    return self.hoursTalk;
}

-(double) hoursIdle {
    if (!self.hoursIdle) {
        self.hoursIdle = 0;
    }
    
    return self.hoursIdle;
}

-(int) type {
    if (!self.type) {
        self.type = 0;
    }
    
    return self.type;
}

+ (id) battery {
    return [[Battery alloc] init];
}

+ (id) batteryWithHoursTalk: (double) hoursTalk
                  hoursIdle: (double) hoursIdle {
    return [[Battery alloc] initWithHoursTalk:hoursTalk hoursIdle:hoursIdle];
}

+ (id) batteryWithType: (Battery_Types) type
             hoursTalk: (double) hoursTalk
             hoursIdle: (double) hoursIdle {
    return [[Battery alloc] initWithType:type hoursTalk:hoursTalk hoursIdle:hoursIdle];
}

@end