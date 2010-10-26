using System;
using System.Linq;
using AutoMapper;
using Weblitz.Mvc.Forum.Db;

namespace Weblitz.Mvc.Forum.Web.Models.Mappings
{
    public class ForumProfile : Profile
    {
        protected override void Configure()
        {
            ForSourceType<DateTime>()
                .AddFormatExpression(x => ((DateTime) x.SourceValue).ToString("dd/MM/YYYY hh:mm tt"));

            CreateMap<Db.Forum, ForumSummary>()
                .ForMember(d => d.TopicCount,
                           o => o.MapFrom(s => s.Topics.Count))
                .ForMember(d => d.PostCount,
                           o => o.MapFrom(s => s.Topics.Sum(topic => topic.Posts.Count)));

            CreateMap<Db.Forum, ForumDetail>();

            CreateMap<Topic, TopicSummary>()
                .ForMember(d => d.PostCount,
                           o => o.MapFrom(s => s.Posts.Count))
                .ForMember(d => d.IsSticky,
                           o => o.MapFrom(s => s.Sticky));

            CreateMap<Db.Forum, ForumInput>()
                .ForMember(d => d.Id,
                           o => o.Ignore());

            CreateMap<Topic, TopicDetail>()
                .ForMember(d => d.Forum,
                           o => o.MapFrom(s => s.Forum.Name))
                .ForMember(d => d.NewPost,
                           o => o.MapFrom(s => new PostInput{TopicId = s.Id}));

            CreateMap<Post, PostDetail>();

            CreateMap<Post, PostInput>();

            CreateMap<Db.Forum, DeleteItem>()
                .ForMember(d => d.Description,
                           o => o.MapFrom(s => s.Name));

            CreateMap<Topic, DeleteItem>()
                .ForMember(d => d.Description,
                           o => o.MapFrom(s => s.Title));

            CreateMap<Post, DeleteItem>()
                .ForMember(d => d.Description,
                           o => o.MapFrom(s => s.Body));
        }

        public override string ProfileName
        {
            get { return "ForumProfile"; }
        }
    }
}