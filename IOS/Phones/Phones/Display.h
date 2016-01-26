//
//  Display.h
//  Phones
//
//  Created by John Doe on 1/26/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#ifndef Display_h
#define Display_h

@interface Display : NSObject
    @property(nonatomic) double size;
    @property(nonatomic) int colorsCount;
-(id) initWithSize:(double) size
       colorsCount: (int) colorsCount;
@end

#endif /* Display_h */
