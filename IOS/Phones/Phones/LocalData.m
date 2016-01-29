//
//  LocalData.m
//  Phones
//
//  Created by John Doe on 1/29/16.
//  Copyright © 2016 John Doe. All rights reserved.
//

#import "LocalData.h"
#import "Phone.h"

@interface LocalData()

@property NSMutableArray *_phones;

@end

@implementation LocalData

- (instancetype)init
{
    self = [super init];
    if (self) {
        self._phones = [NSMutableArray array];
    }
    return self;
}

-(NSArray*) phones {
    return [NSArray arrayWithArray:self._phones];
}

-(void)addPhone:(Phone *)phone {
    [self._phones addObject: phone];
}

-(void)deletePhone:(Phone *)phone {
    NSInteger index = [self._phones indexOfObject:phone];
    [self._phones removeObjectAtIndex:index];
}

@end