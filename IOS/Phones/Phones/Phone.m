//
//  Phone.m
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Phone.h"

@implementation Phone

- (id) initWithManufacturer:(NSString *)manufacturer
                      model:(NSString *)model
                      price:(double)price
                      owner:(NSString *)owner
                    battery:(Battery *)battery
                    display:(Display *)display
    {
    if(self = [super init]) {
        self. manufacturer = manufacturer;
        self.model = model;
        self.price = price;
        self.owner = owner;
        self.battery = battery;
        self.display = display;
    }
    
    return self;
}

@end