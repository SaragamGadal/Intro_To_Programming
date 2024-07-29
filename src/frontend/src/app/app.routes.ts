import { Routes } from '@angular/router';
import { NewIssueComponent } from './components/new-issue.component';
import { IssueListComponent } from './components/issue-list.component';

export const routes: Routes = [
    {
        path: 'new-issue', 
        component: NewIssueComponent
    },
    {
        path: 'issues',
        component: IssueListComponent
    }
];