import { Injectable } from '@angular/core';

@Injectable()
export class EmptyService {
  constructor() {}

  setEntry(key: string) {}

  getEntry(key: string, object?: boolean) {}

  removeEntry(key: string) {}

  clearAllEntries() {}
}
