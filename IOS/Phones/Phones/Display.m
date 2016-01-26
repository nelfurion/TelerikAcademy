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

-(id) initWithSize:(double)size
       colorsCount:(int)colorsCount {
    if (self = [super init]) {
        self.size = size;
        self.colorsCount = colorsCount;
    }
    
    return self;
}

@end
