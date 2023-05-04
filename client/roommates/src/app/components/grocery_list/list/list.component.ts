import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Item } from 'src/app/models/Item';
import { ItemsService } from 'src/app/services/items.service';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.scss']
})
export class ListComponent implements OnInit {

  list: string[] = []
  newItem = new FormControl('')

  constructor(private s_items: ItemsService) { }

  ngOnInit(): void {
    this.s_items.items.subscribe((item: any) => this.list.push(item.name))
  }

  addItem(item: string | null) {
    if (item != null) {
      this.s_items.addItem(new Item(item))
      this.newItem.reset();
    }
  }
}
