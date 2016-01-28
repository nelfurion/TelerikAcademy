//
//  Display.m
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Display.h"

@implementation Display

-(NSString *)description {
    
    return [
            NSString stringWithFormat:@"%f %d",
            self.size,
            self.colorsCount];
}

- (id) initWithSize: (double) size
       colorsCount: (int) colorsCount {
    if (self = [super init]) {
        self.size = size;
        self.colorsCount = colorsCount;
    }
    
    return self;
}

- (id) init {
    return [super init];
}

- (double) size {
    if (!self.size) {
        self.size = 0;
    }
    
    return self.size;
}

- (int) colorsCount {
    if (!self.colorsCount) {
        self.colorsCount = 0;
    }
    
    return self.colorsCount;
}

+ (id) display {
    return [Display init];
}

+ (id) displayWithSize: (double) size
           colorsCount: (int) colorsCount {
    return [[Display alloc] initWithSize:size colorsCount:colorsCount];
}

@end
