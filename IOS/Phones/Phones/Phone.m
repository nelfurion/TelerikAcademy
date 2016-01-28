//
//  Phone.m
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Phone.h"
#import "Battery_Type.h"

@implementation Phone
-(NSString *)description {
    NSString *priceAsText = [NSString stringWithFormat:@"%f", self.price];
    
    return [
            NSString stringWithFormat:@"%@ %@ %@ %@ %@ %@",
            self.manufacturer,
            self.model,
            self.owner,
            priceAsText,
            self.battery,
            self.display];
}

- (id) init {
    self = [super init];
    
    return self;
}

- (id) initWithModel:(NSString *)model manufacturer:(NSString *)manufacturer {
    if (self = [Phone init]) {
        self.manufacturer = manufacturer;
        self.model = model;
    }
    
    return self;
}

- (id) initWithManufacturer:(NSString *)manufacturer
                      model:(NSString *)model
                      price:(double)price
                      owner:(NSString *)owner
                    battery:(Battery *)battery
                    display:(Display *)display
    {
    if(self = [Phone init]) {
        self. manufacturer = manufacturer;
        self.model = model;
        self.price = price;
        self.owner = owner;
        self.battery = battery;
        self.display = display;
    }
    
    return self;
}

- (NSString *) manufacturer {
    if (!self.manufacturer) {
        self.manufacturer = @"";
    }
    
    return self.manufacturer;
}

- (NSString *) model {
    if (!self.model) {
        self.model = @"";
    }
    
    return self.model;
}

- (NSString *) owner {
    if (!self.owner) {
        self.owner = @"";
    }
    
    return self.owner;
}

- (double) price {
    if (!self.price) {
        self.price = 0;
    }
    
    return self.price;
}

- (Battery *) battery {
    if (!self.battery) {
        self.battery = [Battery battery];
    }
    
    return self.battery;
}

- (Display *) display {
    if (!self.display) {
        self.display = [Display display];
    }
    
    return self.display;
}

+ (id) phoneWithManufacturer:(NSString*) manufacturer
                       model: (NSString*) model
                       price:(double) price
                       owner:(NSString*) owner
                     battery:(Battery*) battery
                     display:(Display*) display {
    Phone *phone = [[Phone alloc] initWithManufacturer:manufacturer model:model price:price owner:owner battery:battery display:display];
    phone.manufacturer = manufacturer;
    phone.model = model;
    phone.price = price;
    phone.owner = owner;
    phone.battery = battery;
    phone.display = display;
    
    return phone;
}

+ (id) phone {
    return [[Phone alloc] init];
}

+ (id) phoneWithModel: (NSString*) model
         manufacturer: (NSString*) manufacturer {
    return [[Phone alloc] initWithModel:model manufacturer:manufacturer];
}

+ (id) IPhone5S {
    Battery *iphoneBattery = [Battery batteryWithType:LiIon
                                           hoursTalk:20
                                           hoursIdle:40];
    
    Display *iphoneDisplay = [Display displayWithSize:20 colorsCount:30];
    Phone *iphone = [Phone phoneWithManufacturer:@"Apple"
                                          model:@"IPhone5S"
                                          price:20
                                          owner:@"Dr.Edmond"
                                         battery:iphoneBattery
                                         display:iphoneDisplay];
    
    return iphone;
}

@end