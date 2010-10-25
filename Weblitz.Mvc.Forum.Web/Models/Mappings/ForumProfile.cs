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

            CreateMap<ForumInput, Db.Forum>()
                .ForMember(d => d.Id,
                           o => o.Ignore())
                .ForMember(d => d.Topics,
                           o => o.Ignore());

            CreateMap<Topic, TopicDetail>()
                .ForMember(d => d.Forum,
                           o => o.MapFrom(s => s.Forum.Name))
                .ForMember(d => d.NewPost,
                           o => o.Ignore());

            CreateMap<Post, PostDetail>();
        }

        public override string ProfileName
        {
            get { return "ForumProfile"; }
        }
    }
}