//
//  Phone.h
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#ifndef Phone_h
#define Phone_h
#import "Battery.h"
#import "Display.h"

@interface Phone : NSObject
    @property(strong, nonatomic) NSString* manufacturer;
    @property(strong, nonatomic) NSString* model;
    @property(nonatomic) double price;
    @property(strong, nonatomic) NSString* owner;
    @property(strong, nonatomic) Battery* battery;
    @property(strong, nonatomic) Display* display;

- (NSString *) manufacturer;
- (NSString *) model;
- (double) price;
- (NSString *) owner;
- (Battery *) battery;
- (Display *) display;


- (id) initWithManufacturer: (NSString*)manufacturer
                      model: (NSString*) model
                      price: (double) price
                      owner: (NSString*) owner
                    battery: (Battery*) battery
                    display: (Display*) display;
- (id) init;
- (id) initWithModel: (NSString*) model manufacturer: (NSString*) manufacturer;

+ (id) phoneWithManufacturer:(NSString*) manufacturer
                       model: (NSString*) model
                       price:(double) price
                       owner:(NSString*) owner
                     battery:(Battery*) battery
                     display:(Display*) display;
+ (id) phone;
+ (id) phoneWithModel: (NSString*) model
         manufacturer: (NSString*) manufacturer;

+ (id) IPhone5S;

@end

#endif /* Phone_h */
