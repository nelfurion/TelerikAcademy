//
//  LocalData.h
//  Phones
//
//  Created by John Doe on 1/29/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#ifndef LocalData_h
#define LocalData_h

#import <Foundation/Foundation.h>
#import "Phone.h"

@interface LocalData : NSObject

-(NSMutableArray*) phones;
-(void) addPhone: (Phone *) phone;
-(void) deletePhone: (Phone *) phone;

@end

#endif /* LocalData_h */
