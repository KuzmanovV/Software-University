import { Component } from '@angular/core';
import { ContentService } from './content.service';
import { IPost, ITheme } from './shared/interfaces';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  recentPosts: IPost[] | undefined;

  constructor(private contentService: ContentService) { 
    this.fetchRecentPosts();
  }
  
  fetchRecentPosts(): void{
    this.recentPosts = undefined;
    this.contentService.loadPosts(5).subscribe(posts => this.recentPosts = posts);
  }
}
